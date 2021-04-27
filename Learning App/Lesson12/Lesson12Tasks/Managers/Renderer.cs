using Learning_App.Lesson12.Lesson12Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.Lesson12Tasks.Managers
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
    }
}
