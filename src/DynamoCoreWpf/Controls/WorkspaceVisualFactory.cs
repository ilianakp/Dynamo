using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using VirtualCanvasDemo.Interfaces;
using Dynamo.ViewModels;
using Dynamo.Controls;
using Dynamo.Nodes;

namespace Dynamo.Views
{
    public class WorkspaceVisualFactory : IVisualFactory
    {
        public void BeginRealize()
        {
            // Called before VirtualCanvas starts realizing items
        }

        public void EndRealize()
        {
            // Called after VirtualCanvas finishes realizing items
        }

        public Visual Realize(object dataItem, bool isNew)
        {
            if (dataItem is NodeViewModel nodeItem)
            {
                return CreateNodeView(nodeItem);
            }
            if (dataItem is AnnotationViewModel annotationItem)
            {
                return CreateAnnotationView(annotationItem);
            }
            if (dataItem is NoteViewModel noteItem)
            {
                return CreateNoteView(noteItem);
            }

            return new TextBlock { Text = "Unknown Item", Foreground = Brushes.Red };
        }

        private FrameworkElement CreateNodeView(NodeViewModel nodeItem)
        {
            var nodeView = new NodeView { DataContext = nodeItem };
            return nodeView;
        }

        private FrameworkElement CreateAnnotationView(AnnotationViewModel annotationItem)
        {
            var annotationView = new AnnotationView { DataContext = annotationItem };
            return annotationView;
        }

        private FrameworkElement CreateNoteView(NoteViewModel noteItem)
        {
            var noteView = new NoteView { DataContext = noteItem };
            return noteView;
        }

        public bool Virtualize(Visual visual)
        {
            return true;
        }
    }
}
