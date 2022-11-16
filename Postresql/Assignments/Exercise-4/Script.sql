update user_table 
set isactive = B'0'
where createddate < '2022-11-16';

update user_table 
set createddate = '2022-11-16'
where isactive = B'0';

delete from usergroup ug
where ug.groupid = 2;

delete from group_table g
where g.id = 2;

