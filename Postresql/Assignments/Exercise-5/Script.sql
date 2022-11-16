alter table user_table
alter column id ADD GENERATED ALWAYS AS IDENTITY;

alter table group_table 
alter column id ADD GENERATED ALWAYS AS IDENTITY;

alter table usergroup 
alter column id ADD GENERATED ALWAYS AS IDENTITY;