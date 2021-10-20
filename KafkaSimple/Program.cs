using Confluent.Kafka;
using System;
using System.Collections.Generic;

namespace KafkaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            string kafkaEndPoint = "localhost:9092";
            string kafkaTopic = "TestTopic";
            string input;

            var producerConfig = new ProducerConfig()
            {
                BootstrapServers = kafkaEndPoint                
            };


            //Single input
            //using (var producer = new ProducerBuilder<Null, string>(producerConfig).Build())
            //{
            //    producer.Flush();
            //    producer.Produce(kafkaTopic, new Message<Null, string> { Value = $"Hello Allscripts" });
            //}

            // Continuously monitors input.        
            while ((input = Console.ReadLine()) != null)
            {
                var cmd = input.Substring(0, input.Length);
                switch (cmd)
                {
                    case "quit":
                        return; // Stop the run thread
                }

                //Create producer
                using (var producer = new ProducerBuilder<Null, string>(producerConfig).Build())
                {
                    Console.WriteLine($"Pushing message with value: {cmd} in topic: {kafkaTopic}");
                    producer.Produce(kafkaTopic, new Message<Null, string> { Value = $"{cmd}" });
                }
            }            
        }
    }
}
