
-- ******************************************************************************************************************************* قاعدة بيانات المحاجر

create database Quarantine_Program;
go

ALTER DATABASE Quarantine_Program COLLATE Arabic_CI_AS;-------------------------- تغيير الترميز او الكوليجن لتتعرف قاعدة البيانات على اللغة العربية
GO


----use master
----go
----alter database Quarantine_Program set single_user with rollback immediate
----drop database Quarantine_Program

use Quarantine_Program;
go
-- ******************************************************************************************************************************* جدول الجنسيات
create table tbl_Nationality
(
Nationality_Arabic nvarchar(50)primary key, 
Nationality_Einglish nvarchar(50) ,
);
go
insert into tbl_Nationality values ('المملكة العربية السعودية','Saudi Arabia');
insert into tbl_Nationality values ('الكويت','Kuwait');
insert into tbl_Nationality values ('الامارات العربية المتحدة','Arab Emirates');
insert into tbl_Nationality values ('عمان','Oman');
insert into tbl_Nationality values ('قطر','Qatar');
insert into tbl_Nationality values ('البحرين','Bahrain');
insert into tbl_Nationality values ('مصر','Egypt');
insert into tbl_Nationality values ('السودان','Sudan');
insert into tbl_Nationality values ('باكستان','Pakistan');
insert into tbl_Nationality values ('الهند','India');
insert into tbl_Nationality values ('بنجلاديش','Bangladesh');
insert into tbl_Nationality values ('الفلبين','Philippines');
insert into tbl_Nationality values ('تايلند','Thailand');
insert into tbl_Nationality values ('تركيا','Turkey');
insert into tbl_Nationality values ('تونس','Tunisia');
insert into tbl_Nationality values ('المغرب','Morocco');
insert into tbl_Nationality values ('الجزائر','Algeria');
insert into tbl_Nationality values ('ليبيا','Libya');
insert into tbl_Nationality values ('سوريا','Syria');
insert into tbl_Nationality values ('الاردن','Jordan');
insert into tbl_Nationality values ('فلسطين','Palestine');
insert into tbl_Nationality values ('سريلانكا','Sri Lanka');
insert into tbl_Nationality values ('الصين','China');
insert into tbl_Nationality values ('كوريا الجنوبية','South Korea');
insert into tbl_Nationality values ('اندونسيا','Indonesia');
insert into tbl_Nationality values ('افغانستان','Afghanistan');
insert into tbl_Nationality values ('العراق','Iraq');
insert into tbl_Nationality values ('اثيوبيا','Ethiopia');
insert into tbl_Nationality values ('اوغندا','Uganda');
insert into tbl_Nationality values ('نيجيريا','Nigeria');
insert into tbl_Nationality values ('لبنان','Lebanon');



----select Nationality_Arabic,Nationality_Einglish from tbl_Nationality
go

-- ******************************************************************************************************************************* جدول انواع الهويات
create table tbl_IdType
(
IdType_Arabic nvarchar(50) primary key,
IdType_Einglish nvarchar(50) 

);
go

insert into tbl_IdType values ('إقامة','Iqama');
insert into tbl_IdType values ('بطاقة الهوية الوطنية','National Identity');
insert into tbl_IdType values ('جواز','Passport');
insert into tbl_IdType values ('أخرى','Others');
go
----select IdType_Arabic,IdType_Einglish from tbl_IdType;
-- ******************************************************************************************************************************* جدول الضيوف
create table Tbl_Quest
(
Quest_IdNo nvarchar(15) primary key ,
Quest_IdType nvarchar(50) references tbl_IdType(IdType_Arabic),
Quest_Name nvarchar(50),
Quest_Nationality nvarchar(50) references tbl_Nationality(Nationality_Arabic),
Quest_DateOfBirth datetime,
Quest_Gender nvarchar(7),
Quest_FileNo nvarchar(50)
);
go

----insert into Tbl_Quest values ('111','إقامة','اليوم ولد','المملكة العربية السعودية','2020/06/02','ذكر','6546601');
----insert into Tbl_Quest values ('222','إقامة','يوم اليامي','المملكة العربية السعودية','2020/06/01','ذكر','6545502');
----insert into Tbl_Quest values ('333','إقامة','شهر اليامي','المملكة العربية السعودية','2020/05/02','ذكر','46546603');
----insert into Tbl_Quest values ('444','إقامة','سنتين اليامي','الكويت','2019/06/02','انثى','6546604');
----insert into Tbl_Quest values ('555','إقامة','اليوم قبل ساعة وثلاثين دقيقة','الكويت','2020/06/02 08:30:00 am','انثى','6546605');
----insert into Tbl_Quest values ('666','إقامة','يوم اليامي قبل ساعتين وثلاثين دقيقة','الامارات العربية المتحدة','2020/06/01 07:30:00 am','انثى','6545506');
----insert into Tbl_Quest values ('888','جواز','يوم اليامي قبل ساعتين وثلاثين دقيقة','المملكة العربية السعودية','2020/06/01 07:30:00 am','انثى','6545506');

----select Quest_IdNo,Quest_IdType,Quest_Name,Quest_Nationality,Quest_DateOfBirth,Quest_Gender,Quest_FileNo,dbo.FnCoputeDifferenceBetweenTwoDatesByDay(Quest_DateOfBirth,getdate()) as age from Tbl_Quest
go
-- *******************************************************************************************************************************  مناطق المملكة
create table tbl_Almantiq
(
Almantiq_name nvarchar(50) primary key,
Almantiq_name_Einglish nvarchar(50) ,
Almantiq_no int identity unique

);
go
----insert into tbl_Almantiq values('نجران','najran');
----insert into tbl_Almantiq values('مكة','makkah');
----insert into tbl_Almantiq values('تبوك','tabuk');
----go
------select Almantiq_name from tbl_Almantiq
-- *******************************************************************************************************************************  محافظات المملكة
create table tbl_city
(
city_name nvarchar(50)  primary key,
city_Almantiqname nvarchar(50) references tbl_Almantiq(Almantiq_name) on update cascade ,
City_no int identity unique
);
----go
----insert into tbl_city values('الوجه','تبوك');
----insert into tbl_city values('نجران','نجران');
----insert into tbl_city values('حبونا','نجران');
----insert into tbl_city values('جدة','مكة');
----insert into tbl_city values('مكة','مكة');
----insert into tbl_city values('يدمه','نجران');
----go
----update tbl_city set city_name = 'aa' where city_no =1
------select city_name from tbl_city where city_Almantiqname = 'نجران'
-- *******************************************************************************************************************************  جدول المحاجر
create table tbl_Quarry
(
Quarry_GeneralNo int identity(100,1) primary key ,
Quarry_QuarryName nvarchar(50) unique,
Quarry_CityName nvarchar(50) references tbl_city(city_name) on update cascade,
Quarry_AlmantiqaName nvarchar(50)references tbl_Almantiq(Almantiq_name) 
);
go

----insert into tbl_Quarry values ('مفرق شرورة','نجران','نجران');
----insert into tbl_Quarry values ('الفيصلية','نجران','نجران');
----insert into tbl_Quarry values ('العان','نجران','نجران');
----go
-- ******************************************************************************************************************************* جدول الغرف

create table tbl_Room
(
Room_GeneralNo int identity(1000,1) primary key,
Room_QuarryGeneralNo int references tbl_Quarry(Quarry_GeneralNo) on update cascade,
Room_no nvarchar(50) ,
Room_Floor nvarchar(50)
);
go

----insert into tbl_Room values (100,'11','1');
----insert into tbl_Room values (100,'12','1');
----insert into tbl_Room values (100,'13','1');
----insert into tbl_Room values (100,'14','1');
----insert into tbl_Room values (100,'15','1');
----insert into tbl_Room values (100,'21','2');
----insert into tbl_Room values (100,'22','2');
----insert into tbl_Room values (100,'23','2');
----insert into tbl_Room values (100,'24','2');
----insert into tbl_Room values (100,'25','2');
----insert into tbl_Room values (100,'31','3');
----insert into tbl_Room values (100,'32','3');
----insert into tbl_Room values (100,'33','3');
----insert into tbl_Room values (100,'34','3');
----insert into tbl_Room values (100,'35','3');

----insert into tbl_Room values (101,'11','1');
----insert into tbl_Room values (101,'12','1');
----insert into tbl_Room values (101,'13','1');
----insert into tbl_Room values (101,'14','1');
----insert into tbl_Room values (101,'15','1');
----insert into tbl_Room values (101,'21','2');
----insert into tbl_Room values (101,'22','2');
----insert into tbl_Room values (101,'23','2');
----insert into tbl_Room values (101,'24','2');
----insert into tbl_Room values (101,'25','2');
----insert into tbl_Room values (101,'31','3');
----insert into tbl_Room values (101,'32','3');
----insert into tbl_Room values (101,'33','3');
----insert into tbl_Room values (101,'34','3');
----insert into tbl_Room values (101,'35','3');

----insert into tbl_Room values (102,'11','1');
----insert into tbl_Room values (102,'12','1');
----insert into tbl_Room values (102,'13','1');
----insert into tbl_Room values (102,'14','1');
----insert into tbl_Room values (102,'15','1');
----insert into tbl_Room values (102,'21','2');
----insert into tbl_Room values (102,'22','2');
----insert into tbl_Room values (102,'23','2');
----insert into tbl_Room values (102,'24','2');
----insert into tbl_Room values (102,'25','2');
----insert into tbl_Room values (102,'31','3');
----insert into tbl_Room values (102,'32','3');
----insert into tbl_Room values (102,'33','3');
----insert into tbl_Room values (102,'34','3');
----insert into tbl_Room values (102,'35','3');

----go
-- *******************************************************************************************************************************  جدول الدخول

create table Tbl_Entry
(
Entry_ReservationNo int identity(1000000,1) primary key,
Entry_QuestIdNo nvarchar(15) unique references Tbl_Quest(Quest_IdNo),
Entry_RoomGeneralNo int references tbl_Room(Room_GeneralNo) unique,
Entry_DateTimeOfEntry datetime ,
Entry_DateTimeOfExit datetime 
);
go
----drop table Tbl_Entry
----insert into Tbl_Entry values ('111',1006,'2020/05/25',null);
----insert into Tbl_Entry values ('222',1001,'2020/05/25',null);
----insert into Tbl_Entry values ('333',1002,'2020/05/25',null);
----insert into Tbl_Entry values ('444',1003,'2020/05/25',null);
----insert into Tbl_Entry values ('555',1004,'2020/06/02 08:30:00 am',null);
----insert into Tbl_Entry values ('666',1005,'2020/06/02 07:30:00 am',null);
----select * from tbl_Room
go
-- ******************************************************************************************************************************* جدول الخروج

create table Tbl_Exit
(
Exit_ReservationNo int ,
Exit_QuestIdNo nvarchar(15)  references Tbl_Quest(Quest_IdNo),
Exit_RoomGeneralNo int ,
Exit_DateTimeOfEntry datetime ,
Exit_DateTimeOfExit datetime 
);
go
----delete from Tbl_Exit
----drop table Tbl_Exit
----insert into Tbl_Exit values (1000089,'555',1004,'2020/06/02 08:30:00 am','2020/06/02 10:00:00');
----insert into Tbl_Exit values (1000090,'666',1005,'2020/06/02 07:30:00 am','2020/06/02 08:30:00');
--go
-- *******************************************************************************************************************************  انشاء وظيفة لحساب الفرق بين تاريخين بالدقيقة

create function FnCoputeDifferenceBetweenTwoDates(@oldDate datetime,@newDate datetime)
returns nvarchar(50)
as
begin
declare @tempdate datetime,@years int , @months int , @days int , @hours int , @minute int
select @tempdate=@oldDate

set @years = datediff(year,@tempdate,@newDate)-
case when (MONTH(@tempdate)>month(@newDate) or (month(@tempdate)=month(@newDate) and day(@tempdate)>day(@newDate)) or( month(@tempdate)=month(@newDate) and day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)> DATEPART(hour,@newDate)) or (  month(@tempdate)=month(@newDate) and day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)= DATEPART(hour,@newDate)  and DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate))) then 1 else 0 end
set @tempdate=DATEADD(year,@years,@tempdate )

set @months = datediff(MONTH,@tempdate,@newDate)-
case when  ( day(@tempdate)>day(@newDate)) or ( day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)> DATEPART(hour,@newDate)) or    ( day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)= DATEPART(hour,@newDate)  and DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate)) then 1 else 0 end
set @tempdate=DATEADD(MONTH,@months,@tempdate )

set @days = datediff(DAY,@tempdate,@newDate)-
case when   DATEPART(hour,@tempdate)> DATEPART(hour,@newDate) or ( DATEPART(hour,@tempdate)= DATEPART(hour,@newDate)  and DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate)) then 1 else 0 end
set @tempdate=DATEADD(DAY,@days,@tempdate )

set @hours = datediff(HOUR,@tempdate,@newDate)-
case when   DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate) then 1 else 0 end
set @tempdate=DATEADD(HOUR,@hours,@tempdate )

set @minute = datediff(MINUTE,@tempdate,@newDate)
set @tempdate=DATEADD(MINUTE,@minute,@tempdate )


declare @Difference nvarchar(120);
set @Difference ='المدة: '+cast(@years as nvarchar(4))+' سنة و '+cast(@months as nvarchar(2))+' شهر و '+cast(@days as nvarchar(2))+' يوم و '+cast(@hours as nvarchar(2))+' ساعة و '+  cast(@minute as nvarchar(2))+' دقيقة'
return @Difference ;

end

go
----DROP FUNCTION FnCoputeDifferenceBetweenTwoDates

--select dbo.FnCoputeDifferenceBetweenTwoDates('2020/06/10 09:40:02 am','2021/06/10 09:39:02 am')
----select dbo.FnCoputeDifferenceBetweenTwoDates('1983/02/16 12:00:00 pm', getdate())

-- *******************************************************************************************************************************  انشاء وظيفة لحساب الفرق بين تاريخين باليوم

create function FnCoputeDifferenceBetweenTwoDatesByDay(@oldDate datetime,@newDate datetime)
returns nvarchar(50)
as
begin
declare @tempdate datetime,@years int , @months int , @days int , @hours int , @minute int
select @tempdate=@oldDate

set @years = datediff(year,@tempdate,@newDate)-
case when (MONTH(@tempdate)>month(@newDate) or (month(@tempdate)=month(@newDate) and day(@tempdate)>day(@newDate)) or( month(@tempdate)=month(@newDate) and day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)> DATEPART(hour,@newDate)) or (  month(@tempdate)=month(@newDate) and day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)= DATEPART(hour,@newDate)  and DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate))) then 1 else 0 end
set @tempdate=DATEADD(year,@years,@tempdate )

set @months = datediff(MONTH,@tempdate,@newDate)-
case when  ( day(@tempdate)>day(@newDate)) or ( day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)> DATEPART(hour,@newDate)) or    ( day(@tempdate)=day(@newDate) and DATEPART(hour,@tempdate)= DATEPART(hour,@newDate)  and DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate)) then 1 else 0 end
set @tempdate=DATEADD(MONTH,@months,@tempdate )

set @days = datediff(DAY,@tempdate,@newDate)-
case when   DATEPART(hour,@tempdate)> DATEPART(hour,@newDate) or ( DATEPART(hour,@tempdate)= DATEPART(hour,@newDate)  and DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate)) then 1 else 0 end
set @tempdate=DATEADD(DAY,@days,@tempdate )

set @hours = datediff(HOUR,@tempdate,@newDate)-
case when   DATEPART(MINUTE,@tempdate)> DATEPART(MINUTE,@newDate) then 1 else 0 end
set @tempdate=DATEADD(HOUR,@hours,@tempdate )

set @minute = datediff(MINUTE,@tempdate,@newDate)
set @tempdate=DATEADD(MINUTE,@minute,@tempdate )


declare @Difference nvarchar(120);

--set @Difference =cast(@minute as nvarchar(2))+'minute'+cast(@hours as nvarchar(2))+'hours'+cast(@days as nvarchar(2))+'days'+cast(@months as nvarchar(2))+'months'+cast(@years as nvarchar(4))+'years'
--set @Difference =' دقيقة '+cast(@minute as nvarchar(2))+' ساعة '+cast(@hours as nvarchar(2))+' يوم '+cast(@days as nvarchar(2))+' شهر '+cast(@months as nvarchar(2))+' سنة '+cast(@years as nvarchar(4))
set @Difference ='المدة: '+cast(@years as nvarchar(4))+' سنة و '+cast(@months as nvarchar(2))+' شهر و '+cast(@days as nvarchar(2))+' يوم  '


return @Difference ;

end
go
----drop function FnCoputeDifferenceBetweenTwoDatesByDay
-- *******************************************************************************************************************************  استعلام المحجورين حاليا
create view View_Entry as
select 
 Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth ,Quest_Gender,age, Quest_FileNo 
 , Entry_ReservationNo , Entry_DateTimeOfEntry 
 , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName 
from 
(
 select 
 Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth ,dbo.FnCoputeDifferenceBetweenTwoDatesByDay(Quest_DateOfBirth,Entry_DateTimeOfEntry ) as age ,Quest_Gender, Quest_FileNo 
 , Entry_ReservationNo , Entry_DateTimeOfEntry 
 , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName 
 from Tbl_Quest
 inner join Tbl_Entry on Tbl_Quest.Quest_IdNo=Tbl_Entry.Entry_QuestIdNo
 inner join tbl_Room on  tbl_Room.Room_GeneralNo =Tbl_Entry.Entry_RoomGeneralNo
 inner join tbl_Quarry on tbl_Room.Room_QuarryGeneralNo=tbl_Quarry.Quarry_GeneralNo
) as xx

 go

-- --select * from View_Entry ---------------------------------------   الحالات الموجودة في المحاجر بالمملكة
----select * from View_Entry where Quest_IdNo='10156455555'  --   الحالات الموجودة في محاجر منطقة نجران
----select * from View_Entry where Quarry_CityName = 'najran'     --   الحالات الموجودة في محاجر مدينة نجران
----select * from View_Entry where Quarry_QuarryName = 'najran1'  -- الحالات الموجودة في محجر نجران 1
----select * from View_Entry where Quarry_QuarryName = 'najran2'  -- الحالات الموجودة في محجر نجران 2
----select * from View_Entry where Quarry_QuarryName = 'habuna1'  -- الحالات الموجودة في محجر حبونا 1
----select * from View_Entry where Quarry_QuarryName = 'najran1'
----select * from View_Entry where Quarry_CityName = 'najran'
----select * from View_Entry where Quarry_AlmantiqaName = 'najran'
----select * from View_Entry 
  -- *******************************************************************************************************************************  استعلام الذين خرجوا من المحجر
 create view View_Exit as
 select
  Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 , Exit_ReservationNo , Exit_DateTimeOfEntry ,Exit_DateTimeOfExit,durationOfStay
 , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName  
 from (
 select 
 Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , dbo.FnCoputeDifferenceBetweenTwoDatesByDay(Quest_DateOfBirth,Exit_DateTimeOfEntry ) as age, Quest_Gender, Quest_FileNo 
 , Exit_ReservationNo , Exit_DateTimeOfEntry ,Exit_DateTimeOfExit,dbo.FnCoputeDifferenceBetweenTwoDates(Exit_DateTimeOfEntry,Exit_DateTimeOfExit) as durationOfStay
 , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName 
 from Tbl_Quest
 inner join Tbl_Exit on Tbl_Quest.Quest_IdNo=Tbl_Exit.Exit_QuestIdNo
 inner join tbl_Room on  tbl_Room.Room_GeneralNo =Tbl_Exit.Exit_RoomGeneralNo
 inner join tbl_Quarry on tbl_Room.Room_QuarryGeneralNo=tbl_Quarry.Quarry_GeneralNo
 ) as xxx

go

----select * from View_Exit ---------------------------------------   الحالات التي خرجت من المحاجر في المملكة
----select * from View_Exit where Quarry_AlmantiqaName='najran'  --   الحالات التي خرجت من محاجر منطقة نجران
----select * from View_Exit where Quarry_CityName = 'najran'     --   الحالات التي خرجت من محاجر مدينة نجران
----select * from View_Exit where Quarry_QuarryName = 'najran1'  -- الحالات التي خرجت من محجر نجران 1
----select * from View_Exit where Quarry_QuarryName = 'najran2'  -- الحالات التي خرجت من محجر نجران 2
----select * from View_Exit where Quarry_QuarryName = 'habuna1'  -- الحالات التي خرجت من محجر حبونا 1



  -- *******************************************************************************************************************************  استعلام لاظهار الغرف الشاغرة
   create view view_freeRooms
   as
 select   
 Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from
 (select 
 '' as Entry_ReservationNo ,'' as Entry_DateTimeOfEntry 
  , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName 
 from tbl_Room 
 inner join tbl_Quarry on tbl_Room.Room_QuarryGeneralNo=tbl_Quarry.Quarry_GeneralNo) as xx
   except
   select Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from
(select 
Entry_ReservationNo ,Entry_DateTimeOfEntry 
  , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName 
 from Tbl_Entry
 inner join tbl_Room on  tbl_Room.Room_GeneralNo =Tbl_Entry.Entry_RoomGeneralNo
 inner join tbl_Quarry on tbl_Room.Room_QuarryGeneralNo=tbl_Quarry.Quarry_GeneralNo)as xxx

----select * from view_freeRooms ---------------------------------------   الاسرة الشاغرفة في جميع المدن
----select * from view_freeRooms where Quarry_AlmantiqaName='najran'  --   الاسرة الشاغرة في منطقة نجران
----select * from view_freeRooms where Quarry_CityName = 'najran'     --   الاسرة الشاغرة في مدينة نجران 
----select * from view_freeRooms where Quarry_QuarryName = 'najran1'  -- الاسرة الشاغرة في محجر نجران 1
----select * from view_freeRooms where Quarry_QuarryName = 'najran2'  -- الاسرة الشاغرة في محجر نجران 2
----select * from view_freeRooms where Quarry_QuarryName = 'habuna1'  -- الاسرة الشاغرة في محجر حبونا 1
go

  -- *******************************************************************************************************************************  جدول المستخدمين وصلاحياتهم
  create table tbl_account
  (
  account_UserLoginName nvarchar(50) primary key ,
  account_UserLoginPassword nvarchar(max),
  account_UserName nvarchar(50),
  account_UserMobile nvarchar(10),

  account_AllCities bit default 0,
  account_AlmantiqaName nvarchar(50),
  account_AlmantiqaName_work bit default 0,
  account_CityName nvarchar(50),
  account_CityName_work bit default 0,
  account_QuarryName nvarchar(50),


  account_insert bit default 0,
  account_update bit default 0,
  account_delete bit default 0,
  account_admin bit default 0,
  account_QuarryName_work bit default 0
  );
  go
  insert into tbl_account values('administrator','HkuEDMPMB','ahmed','0543202331',1,'',0,'',0,'',1,1,1,1,0);
  ----insert into tbl_account values('b','b','ali','0543202332',0,'نجران',1,'نجران',0,'مفرق شرورة',1,1,1,1);
  ----insert into tbl_account values('c','c','saleh','0543202333',0,'نجران',0,'نجران',1,'العان',1,1,1,1);
  ----insert into tbl_account values('d','d','hamed','0543202334',0,'نجران',0,'نجران',0,'الفيصلية',1,1,1,1);
  ----  insert into tbl_account values('e','e','hamed','0543202334',0,'نجران',0,'نجران',0,'الفيصلية',1,1,1,1);
	 ----   insert into tbl_account values('f','f','ahmed salem mahdi','1015530262',0,'نجران',0,'حبونا',0,'مستشفى حبونا العام',1,1,1,1);
  ----insert into tbl_account values('aa','aa','ahmed','0543202331',1,'نجران',0,'نجران',0,'الفيصلية',0,0,0,0);
  ----insert into tbl_account values('bb','bb','ali','0543202332',0,'نجران',1,'نجران',0,'مفرق شرورة',0,0,0,1);
  ----insert into tbl_account values('cc','cc','saleh','0543202333',0,'نجران',0,'نجران',1,'العان',0,0,1,1);
  ----insert into tbl_account values('dd','dd','hamed','0543202334',0,'نجران',0,'نجران',0,'الفيصلية',0,1,1,1);
  ----insert into tbl_account values('ee','ee','hamed','0543202334',0,'نجران',0,'نجران',0,'الفيصلية',1,1,1,1);



  --select * from tbl_account
  --delete from tbl_account
  --drop table tbl_account
--  --********************************************************************************************************************************  استخدام صلاحيات المستخدمين في عرض النتائج
--select * from view_freeRooms ---------------------------------------   الاسرة الشاغرفة في جميع المدن
--select * from view_freeRooms where Quarry_AlmantiqaName=(select account_AlmantiqaName from tbl_account where account_UserLoginName='b')  --   الاسرة الشاغرة في منطقة نجران
--select * from view_freeRooms where Quarry_CityName = (select account_CityName from tbl_account where account_UserLoginName='c')     --   الاسرة الشاغرة في مدينة نجران 
--select * from view_freeRooms where Quarry_QuarryName = (select account_QuarryName from tbl_account where account_UserLoginName='d') -- الاسرة الشاغرة في محجر نجران 1
--select * from view_freeRooms where Quarry_QuarryName = (select account_QuarryName from tbl_account where account_UserLoginName='e')  -- الاسرة الشاغرة في محجر نجران 2
--select * from view_freeRooms where Quarry_QuarryName = (select account_QuarryName from tbl_account where account_UserLoginName='f')  -- الاسرة الشاغرة في محجر حبونا 1

go

--********************************************************************************************************************************  انشاء تريجير عند حذف السجلات من جدول الدخول ونقلها الى جدول الخروج

create trigger trg_DeleteTbl_Entry
on Tbl_Entry
for delete
as
begin
declare @Exit_ReservationNo int,@Exit_QuestIdNo nvarchar(15),@Exit_RoomGeneralNo int,@Exit_DateTimeOfEntry datetime,@Exit_DateTimeOfExit datetime 
select @Exit_ReservationNo=Entry_ReservationNo,@Exit_QuestIdNo=Entry_QuestIdNo,@Exit_RoomGeneralNo=Entry_RoomGeneralNo ,@Exit_DateTimeOfEntry=Entry_DateTimeOfEntry,@Exit_DateTimeOfExit=Entry_DateTimeOfExit from deleted
insert into Tbl_Exit values (@Exit_ReservationNo,@Exit_QuestIdNo,@Exit_RoomGeneralNo,@Exit_DateTimeOfEntry,@Exit_DateTimeOfExit)
end

----delete from Tbl_Entry where Entry_ReservationNo=1000000

----select * from Tbl_Entry
----select * from Tbl_Exit
go

--********************************************************************************************************************************  استعلام لجميع النزلاء الالموجودين والذين خرجوا
create view EntryAndExit 
as
select  
Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 , Exit_ReservationNo as ReservationNo, Exit_DateTimeOfEntry as DateTimeOfEntry,Exit_DateTimeOfExit as DateTimeOfExit,durationOfStay as asdurationOfStay
 , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName  
 from View_Exit
 union
 select 
  Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth ,age,Quest_Gender, Quest_FileNo 
 , Entry_ReservationNo as ReservationNo, Entry_DateTimeOfEntry as DateTimeOfEntry, '' as DateTimeOfExit,'' as asdurationOfStay
 , Room_GeneralNo ,Room_no  ,Room_Floor 
 ,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName 
 from View_Entry

 --------drop view EntryAndExit

 ----select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry, DateTimeOfExit, asdurationOfStay
 ----, Room_GeneralNo ,Room_no  ,Room_Floor 
 ----,Quarry_GeneralNo  ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName  from EntryAndExit 


 -->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


 ------ نزلاء خرجوا من المحجر
 ---- select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_AlmantiqaName = 'نجران' and DateTimeOfExit != '1900-01-01 00:00:00.000' -- جميع النزلاء الذين تم خروجهم حسب المنطقة



 ----  select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_CityName = 'حبونا' and DateTimeOfExit != '1900-01-01 00:00:00.000' -- جميع النزلاء الذين تم خروجهم حسب المدينة



 ----   select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_QuarryName = 'مستشفى حبونا العام' and DateTimeOfExit != '1900-01-01 00:00:00.000'-- جميع النزلاء الذين تم خروجهم حسب المحجر

 ---- --*************************************************************************************************************************************************************************************************************
 ---- -- نزلاء مقيمين في المحجر
 ----   select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_AlmantiqaName = 'نجران' and DateTimeOfExit = '1900-01-01 00:00:00.000' -- جميع النزلاء الذين لم يتم خروجهم حسب المنطقة



 ----  select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_CityName = 'حبونا' and DateTimeOfExit = '1900-01-01 00:00:00.000' -- جميع النزلاء الذين لم يتم خروجهم حسب المدينة



 ----   select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_QuarryName = 'مستشفى حبونا العام' and DateTimeOfExit = '1900-01-01 00:00:00.000'-- جميع النزلاء الذين لم يتم خروجهم حسب المحجر

 ------*************************************************************************************************************************************************************************************************************
 ------ حركة الدخول بين تاريخين
 ---- select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_AlmantiqaName = 'نجران' and DateTimeOfEntry between '1900-01-01 00:00:00.000'and'1900-01-01 00:00:00.000' -- حركة الدخول حسب المنطقة



 ----  select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_CityName = 'حبونا' and DateTimeOfEntry between '1900-01-01 00:00:00.000'and'1900-01-01 00:00:00.000' -- حركة الدخول حسب المدينة



 ----   select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_QuarryName = 'مستشفى حبونا العام' and DateTimeOfEntry between '1900-01-01 00:00:00.000'and'1900-01-01 00:00:00.000'-- حركة الدخول حسب المحجر
 ---- --*************************************************************************************************************************************************************************************************************
 ---- -- حركة الخروج بين تاريخين

 ----   select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_AlmantiqaName = 'نجران' and DateTimeOfExit between '1900-01-01 00:00:00.000'and '1900-01-01 00:00:00.000' -- حركة الخروج حسب المنطقة



 ----  select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_CityName = 'حبونا' and DateTimeOfExit between '1900-01-01 00:00:00.000'and '1900-01-01 00:00:00.000'  -- حركة الخروج حسب المدينة



 ----   select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo 
 ----, ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay
 ----,Room_no  ,Room_Floor 
 ----,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_QuarryName = 'مستشفى حبونا العام' and DateTimeOfExit between '1900-01-01 00:00:00.000'and '1900-01-01 00:00:00.000' -- حركة الخروج حسب المحجر

 ----  --*************************************************************************************************************************************************************************************************************
 ----  --*************************************************************************************************************************************************************************************************************


 

