drop database if exists testDB;

create database testDB;

alter database testDB rename to newtestDB;

create or replace procedure newProcedure()
language plpgsql as 
$$ 
begin 
	alter database newtestDb rename to finaltestDB;
end 
$$;


call newProcedure();

drop database finaltestDB;