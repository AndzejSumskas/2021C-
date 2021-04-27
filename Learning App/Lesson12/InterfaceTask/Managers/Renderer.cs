using Learning_App.Lesson12.InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Managers
{
    class Renderer
    {
        private List<IRenderable> renderItems = new List<IRenderable>();

        public void AddRenderItem(IRenderable renderable)
        {
            renderItems.Add(renderable);
        }

        internal void RenderAll()
        {
            foreach (var item in renderItems)
            {
                item.Render();
            }
        }

        private IRenderable[] renderArray = new IRenderable[5];

        int count = 0;

        public void AddRenderToArray(IRenderable renderable)
        {
            renderArray[count] = renderable;
            count++;
        }

        internal void RenderArray()
        {
            foreach (var item in renderArray)
            {
                item.Render();
            }
        }
    }
}
