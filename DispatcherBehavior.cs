namespace UnityWrap
{
    public class DispatcherBehavior : Behavior
    {
        public Dispatcher Dispatcher { get; } = new Dispatcher();

        protected override void Update()
        {
            Dispatcher.DoWork(DispatcherTiming.Update);
            base.Update();
        }

        protected override void FixedUpdate()
        {
            Dispatcher.DoWork(DispatcherTiming.FixedUpdate);
            base.FixedUpdate();
        }

        protected override void LateUpdate()
        {
            Dispatcher.DoWork(DispatcherTiming.LateUpdate);
            base.LateUpdate();
        }
    }
}
