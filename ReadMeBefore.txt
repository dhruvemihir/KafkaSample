Before running console projects for Producer and Consumer, please follow below things.

Prerequisites:

1.
For Kafka to be running, it needs to have following things:
Download Server JRE according to your OS and CPU architecture from http://www.oracle.com/technetwork/java/javase/downloads/jre8-downloads-2133155.html
Download and extract ZooKeeper using 7-zip from http://zookeeper.apache.org/releases.html
Download and extract Kafka using 7-zip from http://kafka.apache.org/downloads.html. I have used 2.8.1 version. 3.0.0 has some issues with topic creation and Kafka server start.

2. Add following variables in Environment variables:
	i) User variable "JAVA_HOME" with value as "Path of your JRE installation"
	ii) Add System variable "PATH" with value as "%JAVA_HOME%/bin". Run cmd and check with command "Java -version" if it is executing without error.
	iii) Add system variable "ZOOKEEPER_HOME" to the bin of Zookeeper installed. 
	iv) Add System variable "PATH" with value of "%ZOOKEEPER_HOME%\bin".


Zookeeper:
1. Go to your ZooKeeper config directory. For me its C:\zookeeper\conf
2. Rename file “zoo_sample.cfg” to “zoo.cfg”
3. Open zoo.cfg in any text editor.
4. Find and edit dataDir=/tmp/zookeeper to "any preferred value". This step is optional.  
5. Run Zookeeper by opening new CMD window and type "zkServer" command.

KAFKA Server
1. Go to your Kafka installation directory: C:\kafka\ folder
2. Open command prompt and go to Kafka folder.
3. Now type .\bin\windows\kafka-server-start.bat .\config\server.properties and press Enter.

KAFKA Producer:
Compile KAFKAProducer project and run
Enter any value in the and Press enter.

KAFKA Consumer
Compile KAFKAConsumer project and run
Result: Value entered by Producer will be observed by the Subscriber and will show on the console window.