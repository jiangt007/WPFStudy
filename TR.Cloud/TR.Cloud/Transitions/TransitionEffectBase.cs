using System.Windows;
using System.Windows.Media.Animation;
using TR.Cloud.Transitions;

namespace TR.Cloud.Transitions
{
    public abstract class TransitionEffectBase : FrameworkElement, ITransitionEffect
    {
        public abstract Timeline Build<TSubject>(TSubject effectSubject) where TSubject : FrameworkElement, ITransitionEffectSubject;        
    }
}