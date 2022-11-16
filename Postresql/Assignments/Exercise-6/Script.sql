select *
from user_table ut 
where firstname like 'a%'
order by createddate desc ;


select firstname, email 
from user_table ut 
where modifieddate > '2021-10-15';

select *
from group_table gt
where description is null ;