using System;
using System.Text;

using static Arqan.GL;
using static Arqan.Glfw.GLFW;

namespace Arqan.Example2
{
    public class Window
    {
        private int width;
        private int height;
        private string title;

        private readonly Block[] blocks;
        private bool useDelta;

        private GLFWerrorfun glfwErrorFunction;
        private GLFWwindowsizefun glfwWindowSizeFunction;
        private GLFWwindowclosefun glfwWindowCloseFunction;
        private GLFWwindowrefreshfun glfwWindowRefreshFunction;
        private GLFWcursorposfun glfwCursorPosFunction;
        private GLFWmousebuttonfun glfwMouseButtonFunction;
        private GLFWkeyfun glfwKeyFunction;
        private GLFWcharfun glfwCharFunction;

        private nint Handle { get; set; }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;

                if (Handle != nint.Zero)
                {
                    glfwSetWindowSize(Handle, width, height);
                }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;

                if (Handle != nint.Zero)
                {
                    glfwSetWindowSize(Handle, width, height);
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;

                if (Handle != nint.Zero)
                {
                    glfwSetWindowTitle(Handle, value);
                }
            }
        }

        public Window(int width, int height, string title)
        {
            Width = width;
            Height = height;
            Title = title;

            blocks = new Block[10000];

            for (var i = 0; i < blocks.Length; i++)
            {
                var x = new Random().Next(0, width - 32);
                var y = new Random().Next(0, height - 32);

                blocks[i] = new Block(x, y);
            }
        }

        public void Open(bool fullscreen = false, bool vsync = true)
        {
            InitGLFW();
            InitWindow(fullscreen);
            InitEvents();
            InitSettings(vsync);

            Loop();
        }

        public void Close()
        {
            glfwSetWindowShouldClose(Handle, 1);
        }

        private void InitGLFW()
        {
            if (glfwInit() == 0)
            {
                throw new Exception("Unable to initialize glfw");
            }
        }

        private void InitWindow(bool fullscreen)
        {
            Handle = glfwCreateWindow(Width, Height, Encoding.ASCII.GetBytes(Title), fullscreen ? glfwGetPrimaryMonitor() : nint.Zero, nint.Zero);

            if (Handle == nint.Zero)
            {
                glfwTerminate();
                throw new Exception("Unable to create glfw window");
            }

            glfwMakeContextCurrent(Handle);
        }

        private void InitEvents()
        {
            glfwErrorFunction = OnErrorFunction;
            glfwCharFunction = OnCharFunction;
            glfwCursorPosFunction = OnCursorPositionFunction;
            glfwKeyFunction = OnKeyFunction;
            glfwMouseButtonFunction = OnMouseButtonFunction;
            glfwWindowCloseFunction = OnWindowCloseFunction;
            glfwWindowRefreshFunction = OnWindowRefreshFunction;
            glfwWindowSizeFunction = OnWindowSizeFunction;

            glfwSetErrorCallback(glfwErrorFunction);
            glfwSetWindowSizeCallback(Handle, glfwWindowSizeFunction);
            glfwSetWindowCloseCallback(Handle, glfwWindowCloseFunction);
            glfwSetWindowRefreshCallback(Handle, glfwWindowRefreshFunction);
            glfwSetCursorPosCallback(Handle, glfwCursorPosFunction);
            glfwSetMouseButtonCallback(Handle, glfwMouseButtonFunction);
            glfwSetKeyCallback(Handle, glfwKeyFunction);
            glfwSetCharCallback(Handle, glfwCharFunction);
        }

        private void InitSettings(bool vsync)
        {
            if (vsync)
            {
                glfwSwapInterval(1);
            }
            else
            {
                glfwSwapInterval(0);
            }
        }

        private void Loop()
        {
            useDelta = true;
            var lastTime = glfwGetTime();
            
            // Main loop
            while (glfwWindowShouldClose(Handle) == 0)
            {
                double currentTime = glfwGetTime();
                double deltaTime = currentTime - lastTime;
                lastTime = currentTime;

                for (var i = 0; i < blocks.Length; i++)
                {
                    blocks[i].UseDelta = useDelta;
                    blocks[i].Update(deltaTime, width, height);
                }

                // Render a background and enable some stuff for 2d rendering with alpha
                glMatrixMode(GL_PROJECTION);
                glLoadIdentity();
                glOrtho(0, width, height, 0, -1, 1);
                glMatrixMode(GL_MODELVIEW);
                glLoadIdentity();

                glEnable(GL_BLEND);
                glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
                glViewport(0, 0, Width, Height);
                glClearColor(0, 0, 0, 1);
                glClear(GL_COLOR_BUFFER_BIT);

                // Render
                for (var i = 0; i < blocks.Length; i++)
                {
                    blocks[i].Render();
                }

                glfwSwapBuffers(Handle);
                glfwPollEvents();
            }

            glfwDestroyWindow(Handle);
        }

        /* GENERAL FUNCTIONS */
        private void OnErrorFunction(int errorCode, string description)
        {
            throw new Exception($"{errorCode}: {description}");
        }

        private void OnWindowSizeFunction(nint windowHandle, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private void OnWindowRefreshFunction(nint windowHandle)
        {
        }

        private void OnPositionFunction(nint windowHandle, int x, int y)
        {
        }

        private void OnWindowCloseFunction(nint windowHandle)
        {
        }

        /* INPUT FUNCTIONS */
        private void OnCursorPositionFunction(nint windowHandle, double x, double y)
        {
        }

        private void OnMouseButtonFunction(nint windowHandle, int button, int action, int mods)
        {
        }

        private void OnKeyFunction(nint windowHandle, int key, int scanCode, int action, int mods)
        {
            if (key == GLFW_KEY_SPACE && action == GLFW_PRESS)
            {
                useDelta = !useDelta;
                Console.WriteLine("Use delta: " + useDelta);
            }

            if (key == GLFW_KEY_ESCAPE && action == GLFW_PRESS)
            {
                glfwSetWindowShouldClose(windowHandle, 1);
            }
        }

        private void OnCharFunction(nint windowHandle, uint codepoint)
        {
        }
    }
}