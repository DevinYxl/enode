﻿using ECommon.IoC;
using ENode.EQueue;
using ENode.Eventing;

namespace NoteSample.EQueueIntegrations
{
    public class EventTopicManager : IEventTopicProvider
    {
        public string GetTopic(EventStream eventStream)
        {
            return "NoteEventTopic";
        }
    }
}
