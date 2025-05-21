use medidata;
select * from points, connections, connections_tcp where (connections.ConnectionId = connections_tcp.ConnectionId) and (connections.ConnectionId=points.Connection_ConnectionId) and (PointId in (select Point_PointId as 'PointId' from locations where Map_MapId={0}}))

delete from DataRecords where ((Point_PointId=98) and ((RecordTime='2025-04-21 08:25:13') or
	(RecordTime='2025-04-21 08:25:15') or
	(RecordTime='2025-04-21 08:25:17') or
	(RecordTime='2025-04-21 08:25:19') or
	(RecordTime='2025-04-21 08:25:21') or
	(RecordTime='2025-04-21 08:25:23') or (RecordTime='2025-04-21 08:25:25') or (RecordTime='2025-04-21 08:25:27') or (RecordTime='2025-04-21 08:25:29') or (RecordTime='2025-04-21 08:25:31') or
	(RecordTime='2025-04-21 08:25:33')));

select * from datarecords
select * from Connections
select * from Connections_tcp
insert into Connections (ConnectionId,name,DeviceType,ConnectionUnit_ConnectionUnitId,Enable) values (100,'defult','DPU4',1),(101,'DPU4',1,1)

insert into Connections (name,DeviceType,ConnectionUnit_ConnectionUnitId,Enable) values ('defult','DPU4',1,1)
insert into Connections_tcp (ConnectionId,ip,Port) values (41,'169.254.231.129',5000),(42,'169.254.231.129',5000)
select * from maps
select * from Points
insert into Points (name,
