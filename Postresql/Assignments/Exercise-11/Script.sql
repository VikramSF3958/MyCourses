create view confidentialData as
select * from user_table ut where createddate > '2011-11-10';

select * from confidentialData;




create view groupingOnCityDesgn as
select city, designation , sum(salary) from user_table ut group by city , designation;

select * from groupingOnCityDesgn;



create view userswithGroupNames as
select ut.firstname, gt."name"
from user_table ut 
left join usergroup u 
on ut.id  = u.userid
left  join group_table gt 
on u.groupid = gt.id;
					

select * from userswithGroupNames;


create view usersOnlywithGroupNames as
select ut.firstname, gt."name"
from user_table ut 
inner join usergroup u 
on ut.id  = u.userid
inner join group_table gt 
on u.groupid = gt.id;

select * from usersOnlywithGroupNames;