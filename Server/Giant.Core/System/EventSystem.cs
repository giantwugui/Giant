﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Giant.Core
{
    public class EventSystem
    {
        private static DepthMap<Type, long, IUpdateSystem> updateComponent = new DepthMap<Type, long, IUpdateSystem>();
        private static DepthMap<Type, long, ILoadSystem> loadComponent = new DepthMap<Type, long, ILoadSystem>();
        private static ListMap<EventType, IEvent> eventList = new ListMap<EventType, IEvent>();

        private static ListMap<Type, Type> attributeTypes = new ListMap<Type, Type>();

        public void Add(Component component)
        {
            switch (component)
            {
                case IUpdateSystem updateSystem:
                    updateComponent.Add(component.GetType(), component.InstanceId, updateSystem);
                    break;
                case ILoadSystem loadSystem:
                    loadComponent.Add(component.GetType(), component.InstanceId, loadSystem);
                    break;
            }
        }

        public void Remove(Component component)
        {
            updateComponent.Remove(component.GetType(), component.InstanceId);
            loadComponent.Remove(component.GetType(), component.InstanceId);
        }

        public void Update(double delayTime)
        {
            foreach (var kv in updateComponent)
            {
                foreach (var curr in kv.Value)
                {
                    curr.Value.Update(delayTime);
                }
            }
        }

        public void Load()
        {
            foreach (var kv in loadComponent)
            {
                foreach (var curr in kv.Value)
                {
                    curr.Value.Load();
                }
            }
        }

        public List<Type> Get(Type type)
        {
            attributeTypes.TryGetValue(type, out var types);
            return types;
        }

        #region event

        public void Add(Assembly assembly)
        {
            Type type = typeof(ObjectAttribute);
            var objectTypes = assembly.GetTypes().ToList().Where(x => x.GetCustomAttribute(type) != null);
            foreach (Type kv in objectTypes)
            {
                ObjectAttribute objectAttribute = kv.GetCustomAttribute(type) as ObjectAttribute;
                switch (objectAttribute)
                {
                    case EventAttribute eventAttribute:
                        if (!(Activator.CreateInstance(kv) is IEvent @event)) continue;
                        eventList.Add(eventAttribute.EventType, @event);
                        break;
                    case MessageHandlerAttribute messageHandlerAttribute:
                        attributeTypes.Add(messageHandlerAttribute.GetType(), kv);
                        break;
                }
            }
        }

        public void Handle(EventType type)
        {
            if (!eventList.TryGetValue(type, out var eventSystems)) return;
            foreach (var kv in eventSystems)
            {
                if (kv is Event)
                {
                    kv.Run();
                }
            }
        }

        public void Handle<A>(EventType type, A a)
        {
            if (!eventList.TryGetValue(type, out var eventSystems)) return;
            foreach (var kv in eventSystems)
            {
                if (kv is Event<A>)
                {
                    kv.Run(a);
                }
            }
        }

        public void Handle<A, B>(EventType type, A a, B b)
        {
            if (!eventList.TryGetValue(type, out var eventSystems)) return;
            foreach (var kv in eventSystems)
            {
                if (kv is Event<A, B>)
                {
                    kv.Run(a, b);
                }
            }
        }

        public void Handle<A, B, C>(EventType type, A a, B b, C c)
        {
            if (!eventList.TryGetValue(type, out var eventSystems)) return;
            foreach (var kv in eventSystems)
            {
                if (kv is Event<A, B, C>)
                {
                    kv.Run(a, b, c);
                }
            }
        }

        #endregion

    }
}