using System;
using System.Text;

namespace Arqan.Example1
{
    public class Window
    {
        private int width;
        private int height;
        private string title;

        private GLFW.GLFWerrorfun glfwErrorFunction;
        private GLFW.GLFWwindowsizefun glfwWindowSizeFunction;
        private GLFW.GLFWwindowclosefun glfwWindowCloseFunction;
        private GLFW.GLFWwindowrefreshfun glfwWindowRefreshFunction;
        private GLFW.GLFWcursorposfun glfwCursorPosFunction;
        private GLFW.GLFWmousebuttonfun glfwMouseButtonFunction;
        private GLFW.GLFWkeyfun glfwKeyFunction;
        private GLFW.GLFWcharfun glfwCharFunction;

        private nint Handle { get; set; }

        public int Width
        {
            get => width;
            set
            {
                width = value;

                if (Handle != nint.Zero)
                {
                    GLFW.glfwSetWindowSize(Handle, width, height);
                }
            }
        }

        public int Height
        {
            get => height;
            set
            {
                height = value;

                if (Handle != nint.Zero)
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

                if (Handle != nint.Zero)
                {
                    GLFW.glfwSetWindowTitle(Handle, value);
                }
            }
        }

        public Window(int width, int height, string title)
        {
            // Set the properties
            Width = width;
            Height = height;
            Title = title;
        }

        public void Open(bool fullscreen = false, bool vsync = true, bool pollEvents = true)
        {
            InitGLFW();
            InitWindow(fullscreen);
            InitEvents();
            InitSettings(vsync);

            Sync();
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
            Handle = GLFW.glfwCreateWindow(Width, Height, Encoding.ASCII.GetBytes(Title), fullscreen ? GLFW.glfwGetPrimaryMonitor() : nint.Zero, nint.Zero);

            if (Handle == nint.Zero)
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
            GLFW.glfwSwapInterval(vsync ? 1 : 0);
        }

        private void Sync()
        {
            // Main loop
            while (GLFW.glfwWindowShouldClose(Handle) == 0)
            {
                // Update

                // Render a background and enable some stuff for 2d rendering with alpha
                GL.glEnable(GL.GL_BLEND);
                GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);
                GL.glViewport(0, 0, Width, Height);
                GL.glClearColor(0, 0, 0, 1);
                GL.glClear(GL.GL_COLOR_BUFFER_BIT);

                // Render

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

        private void OnWindowSizeFunction(nint windowHandle, int newWidth, int newHeight)
        {
            width = newWidth;
            height = newHeight;
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
            if (key == GLFW.GLFW_KEY_ESCAPE && action == GLFW.GLFW_PRESS)
            {
                GLFW.glfwSetWindowShouldClose(windowHandle, 1);
            }

            if (key == GLFW.GLFW_KEY_M && action == GLFW.GLFW_PRESS)
            {
                GLFW.glfwMaximizeWindow(windowHandle);
            }
        }

        private void OnCharFunction(nint windowHandle, uint codepoint)
        {
        }
    }
}