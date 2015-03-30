﻿namespace Upos.ServiceObject.Base.UposEvents
{
    public static class IUposEventDispatcherFactory
    {
        public static IUposEventDispatcher Create(object controlObjectDispatcher)
        {
            return new UposEventDispatcher(null);
        }
    }

    public interface IUposEventDispatcher
    {
        void EnqueueDirectIOEvent(DirectIOEventArguments args);

        void EnqueueErrorEvent(ErrorEventArguments args);

        void EnqueueOutputCompleteEvent(OutputCompleteEventArguments args);

        void EnqueueStatusUpdateEvent(StatusUpdateEventArguemtns args);
    }
}
