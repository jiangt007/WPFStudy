namespace WM.TR.Cloud.Transitions
{
    public interface IZIndexController
    {
        void Stack(params TransitionerSlide[] highestToLowest);        
    }
}