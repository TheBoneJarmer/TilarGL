using System;
using System.Text;

using static Arqan.GL;
using static Arqan.Glfw.GLFW;

namespace Arqan.Example1
{
    public class Window
    {
        private int width;
        private int height;
        private string title;

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
            get => width;
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
            get => height;
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
            glfwSwapInterval(vsync ? 1 : 0);
        }

        private void Sync()
        {
            // Main loop
            while (glfwWindowShouldClose(Handle) == 0)
            {
                // Update

                // Render a background and enable some stuff for 2d rendering with alpha
                glEnable(GL_BLEND);
                glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
                glViewport(0, 0, Width, Height);
                glClearColor(0, 0, 0, 1);
                glClear(GL_COLOR_BUFFER_BIT);

                // Render

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
            if (key == GLFW_KEY_ESCAPE && action == GLFW_PRESS)
            {
                glfwSetWindowShouldClose(windowHandle, 1);
            }

            if (key == GLFW_KEY_M && action == GLFW_PRESS)
            {
                glfwMaximizeWindow(windowHandle);
            }
        }

        private void OnCharFunction(nint windowHandle, uint codepoint)
        {
        }
    }
}