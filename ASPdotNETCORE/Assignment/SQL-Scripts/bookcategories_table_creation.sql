create table if not exists public.bookcategories
(
	cateogoryId 	int   	not NULL PRIMARY KEY  GENERATED BY DEFAULT AS IDENTITY ,
	cateogoryName 	varchar(255) not NULL,
	updatedOn		Date	not NULL,
	IsDeleted 		boolean	not NULL 
	
);