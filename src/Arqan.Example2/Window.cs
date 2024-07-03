using System;
using System.Text;

namespace Arqan.Example2
{
    public class Window
    {
        private int width;
        private int height;
        private string title;

        private readonly Block[] blocks;
        private bool useDelta;

        private GLFW.GLFWerrorfun glfwErrorFunction;
        private GLFW.GLFWwindowsizefun glfwWindowSizeFunction;
        private GLFW.GLFWwindowclosefun glfwWindowCloseFunction;
        private GLFW.GLFWwindowrefreshfun glfwWindowRefreshFunction;
        private GLFW.GLFWcursorposfun glfwCursorPosFunction;
        private GLFW.GLFWmousebuttonfun glfwMouseButtonFunction;
        private GLFW.GLFWkeyfun glfwKeyFunction;
        private GLFW.GLFWcharfun glfwCharFunction;

        private IntPtr Handle { get; set; }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;

                if (Handle != IntPtr.Zero)
                {
                    GLFW.glfwSetWindowSize(Handle, width, height);
                }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;

                if (Handle != IntPtr.Zero)
                {
                    GLFW.glfwSetWindowSize(Handle, width, height);
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;

                if (Handle != IntPtr.Zero)
                {
                    GLFW.glfwSetWindowTitle(Handle, value);
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
            GLFW.glfwSetWindowShouldClose(Handle, 1);
        }

        private void InitGLFW()
        {
            if (GLFW.glfwInit() == 0)
            {
                throw new Exception("Unable to initialize glfw");
            }
        }

        private void InitWindow(bool fullscreen)
        {
            Handle = GLFW.glfwCreateWindow(Width, Height, Encoding.ASCII.GetBytes(Title), fullscreen ? GLFW.glfwGetPrimaryMonitor() : IntPtr.Zero, IntPtr.Zero);

            if (Handle == IntPtr.Zero)
            {
                GLFW.glfwTerminate();
                throw new Exception("Unable to create glfw window");
            }

            GLFW.glfwMakeContextCurrent(Handle);
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

            GLFW.glfwSetErrorCallback(glfwErrorFunction);
            GLFW.glfwSetWindowSizeCallback(Handle, glfwWindowSizeFunction);
            GLFW.glfwSetWindowCloseCallback(Handle, glfwWindowCloseFunction);
            GLFW.glfwSetWindowRefreshCallback(Handle, glfwWindowRefreshFunction);
            GLFW.glfwSetCursorPosCallback(Handle, glfwCursorPosFunction);
            GLFW.glfwSetMouseButtonCallback(Handle, glfwMouseButtonFunction);
            GLFW.glfwSetKeyCallback(Handle, glfwKeyFunction);
            GLFW.glfwSetCharCallback(Handle, glfwCharFunction);
        }

        private void InitSettings(bool vsync)
        {
            if (vsync)
            {
                GLFW.glfwSwapInterval(1);
            }
            else
            {
                GLFW.glfwSwapInterval(0);
            }
        }

        private void Loop()
        {
            useDelta = true;
            var lastTime = GLFW.glfwGetTime();
            
            // Main loop
            while (GLFW.glfwWindowShouldClose(Handle) == 0)
            {
                double currentTime = GLFW.glfwGetTime();
                double deltaTime = currentTime - lastTime;
                lastTime = currentTime;

                for (var i = 0; i < blocks.Length; i++)
                {
                    blocks[i].UseDelta = useDelta;
                    blocks[i].Update(deltaTime, width, height);
                }

                // Render a background and enable some stuff for 2d rendering with alpha
                GL.glMatrixMode(GL.GL_PROJECTION);
                GL.glLoadIdentity();
                GL.glOrtho(0, width, height, 0, -1, 1);
                GL.glMatrixMode(GL.GL_MODELVIEW);
                GL.glLoadIdentity();

                GL.glEnable(GL.GL_BLEND);
                GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);
                GL.glViewport(0, 0, Width, Height);
                GL.glClearColor(0, 0, 0, 1);
                GL.glClear(GL.GL_COLOR_BUFFER_BIT);

                // Render
                for (var i = 0; i < blocks.Length; i++)
                {
                    blocks[i].Render();
                }

                GLFW.glfwSwapBuffers(Handle);
                GLFW.glfwPollEvents();
            }

            GLFW.glfwDestroyWindow(Handle);
        }

        /* GENERAL FUNCTIONS */
        private void OnErrorFunction(int errorCode, string description)
        {
            throw new Exception($"{errorCode}: {description}");
        }

        private void OnWindowSizeFunction(IntPtr windowHandle, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private void OnWindowRefreshFunction(IntPtr windowHandle)
        {
        }

        private void OnPositionFunction(IntPtr windowHandle, int x, int y)
        {
        }

        private void OnWindowCloseFunction(IntPtr windowHandle)
        {
        }

        /* INPUT FUNCTIONS */
        private void OnCursorPositionFunction(IntPtr windowHandle, double x, double y)
        {
        }

        private void OnMouseButtonFunction(IntPtr windowHandle, int button, int action, int mods)
        {
        }

        private void OnKeyFunction(IntPtr windowHandle, int key, int scanCode, int action, int mods)
        {
            if (key == GLFW.GLFW_KEY_SPACE && action == GLFW.GLFW_PRESS)
            {
                useDelta = !useDelta;
                Console.WriteLine("Use delta: " + useDelta);
            }

            if (key == GLFW.GLFW_KEY_ESCAPE && action == GLFW.GLFW_PRESS)
            {
                GLFW.glfwSetWindowShouldClose(windowHandle, 1);
            }
        }

        private void OnCharFunction(IntPtr windowHandle, uint codepoint)
        {
        }
    }
}