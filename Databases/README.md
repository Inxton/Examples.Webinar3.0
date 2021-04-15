# Working with databases

Steps to run :

1. Open Databases.sln
2. In `HansPlcConnector\Entry.cs` change the AmsId to your PLC, or use null for localhost.
3. Run the project `Program`
4. Csv, excel file will be located in `Program\bin\netcoreapp3.1\stData.csv `
5. Uncomment other lines of code to save to other targets - you need to download and start MongoDB and InfluxDB prior

To start MongoDB 3.6

```
"C:\Program Files\MongoDB\Server\3.6\bin\mongod.exe"  --dbpath C:\path_to_db_folder_that_exists\ --bind_ip_all 
```

To start InfluxDB 1.8.3

```
C:\influxdata\influxdb-1.8.3-1\influxd.exe
```