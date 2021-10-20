using Confluent.Kafka;
using System;

namespace KafkaConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            string kafkaEndPoint = "localhost:9092";

            string kafkaTopic = "TestTopic";

            var consumerConfig = new ConsumerConfig
            {
                BootstrapServers = kafkaEndPoint,
                GroupId= "MyGroup",                
            };

            using (var consumer = new ConsumerBuilder<Null, string>(consumerConfig).Build())
            {
                consumer.Subscribe(kafkaTopic);                
                try
                {
                    while (true)
                    {
                        var consumeResult = consumer.Consume();
                        Console.WriteLine(consumeResult.Message.Value);
                    }
                }
                catch (Exception)
                {
                    consumer.Close();
                }
            }

            Console.ReadLine();
        }
    }
}
