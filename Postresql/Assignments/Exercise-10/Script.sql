CREATE OR REPLACE FUNCTION displayAllDesignation(a varchar(255))
RETURNS SETOF finaltestdb.public.user_table AS $$
BEGIN
  RETURN QUERY SELECT * FROM finaltestdb.public.user_table where designation = $1;
END
$$ LANGUAGE plpgsql;


SELECT * FROM displayAllDesignation('Developer');


create or replace function userSpecifiedDate(d DATE)
returns  setof finaltestdb.public.user_table as $$
begin 
	return query select * from finaltestdb.public.user_table where $1 < createddate
			order by id  asc; 
end
$$ language plpgsql;

select * from userSpecifiedDate('2011-11-15');


create or replace  function userWithGroupName()
returns table(firstname varchar, GroupName varchar) as $$
begin 
	return query select ut.firstname, gt."name"
					from user_table ut 
					left join usergroup u 
					on ut.id  = u.userid
					left  join group_table gt 
					on u.groupid = gt.id;
end
$$ language plpgsql;


select * from userWithGroupName();



create or replace  function userWithGroupNameAfterSpecifiedDate(a date)
returns table(firstname varchar, GroupName varchar) as $$
begin 
	return query select ut.firstname, gt."name"
					from user_table ut 
					inner join usergroup u 
					on ut.id  = u.userid
					inner join group_table gt 
					on u.groupid = gt.id
					where $1 < ut.createddate  ;
end
$$ language plpgsql;


select * from userWithGroupNameAfterSpecifiedDate('2018-11-11');


