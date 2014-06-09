using System;
using SystemDot.Messaging.Handling.Actions;
using SystemDot.Messaging.Simple;
using BlocCrusier.ObjectPooling;

namespace BlocCrusier
{
    public static class GameMessenger
    {
        public static void Send<T>(EntityIdentifier groupId, Action<T> onCreation) where T : new()
        {
            var message = ObjectPool.Get<T>();
            onCreation(message);
            Messenger.Send(message, groupId);
            ObjectPool.Return(message);
        }

        public static ActionSubscriptionToken<T> RegisterHandler<T>(EntityIdentifier groupId, Action<T> toRegister) 
            where T : new()
        {
            return Messenger.RegisterHandler(toRegister, groupId);
        }
    }
}