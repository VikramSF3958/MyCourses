select ut.designation, sum(salary) 
from user_table ut 
group by designation ;


select ut.designation, ut.city, sum(salary) 
from user_table ut 
group by designation ,city;