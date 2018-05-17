using System.Windows;
using System.Windows.Media.Animation;
using WM.TR.Cloud.Transitions;

namespace WM.TR.Cloud.Transitions
{
    public abstract class TransitionEffectBase : FrameworkElement, ITransitionEffect
    {
        public abstract Timeline Build<TSubject>(TSubject effectSubject) where TSubject : FrameworkElement, ITransitionEffectSubject;        
    }
}