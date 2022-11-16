select ut.firstname, gt."name"
from user_table ut 
left join usergroup u 
on ut.id  = u.userid
left  join group_table gt 
on u.groupid = gt.id ;