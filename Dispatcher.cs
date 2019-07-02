using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace UnityWrap
{
    public class Dispatcher
    {
        private readonly IDictionary<DispatcherTiming, ConcurrentQueue<Action>> _queues =
            new Dictionary<DispatcherTiming, ConcurrentQueue<Action>>
            {
                {DispatcherTiming.Update, new ConcurrentQueue<Action>()},
                {DispatcherTiming.FixedUpdate, new ConcurrentQueue<Action>()},
                {DispatcherTiming.LateUpdate, new ConcurrentQueue<Action>()},
            };

        public void Invoke(Action action, DispatcherTiming timing = DispatcherTiming.Update)
        {
            _queues[timing].Enqueue(action);
        }

        internal void DoWork(DispatcherTiming timing)
        {
            var work = GetWork(timing).ToList();
            foreach (var action in work)
            {
                action();
            }
        }

        private IEnumerable<Action> GetWork(DispatcherTiming timing)
        {
            var queue = _queues[timing];

            while (!queue.IsEmpty)
            {
                if (queue.TryDequeue(out var action))
                    yield return action;
                else
                    break;
            }
        }
    }
}
