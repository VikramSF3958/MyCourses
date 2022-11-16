create table user_table (
	
	ID int not null primary key,
	firstname varchar(255),
	lastname varchar(255),
	email varchar(255),
	city varchar(255),
	salary int,
	designation varchar(255),
	CreatedDate timestamp, 
	ModifiedDate timestamp,
	IsActive bit

);


create table group_table (
	
	id int not null primary key,
	name varchar(255),
	Description  varchar(255),
	CreatedDate  timestamp,
	ModifiedDate timestamp,
	IsActive bit
);


create table userGroup (
	
	id int not null primary key,
	groupId int,
	UserId int,
	ModifiedDate timestamp,
	IsActive bit,
	foreign key (groupId) references group_table(id),
	foreign key (UserId) references user_table(ID)
);