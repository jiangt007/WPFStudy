using System.Windows;
using System.Windows.Media.Animation;

namespace TR.Cloud.Transitions
{
    public interface ITransitionEffect
    {
        Timeline Build<TSubject>(TSubject effectSubject) where TSubject : FrameworkElement, ITransitionEffectSubject;
    }
}