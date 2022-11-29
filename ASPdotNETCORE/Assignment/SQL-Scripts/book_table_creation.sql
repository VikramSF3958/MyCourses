create table if not exists public.books
(	
	bookId			INT				NOT NULL	PRIMARY KEY	GENERATED BY DEFAULT AS IDENTITY,
	bookName		varchar(255)	NOT NULL,
	authorName		varchar(250)	NULL,
	publishedYear 	INT 			NULL,
	Price 			NUMERIC(6,2) 	NULL,
	bookcategoryId 	INT 			NOT NULL,
	updatedOn 		DATE 			NOT NULL,
	IsDeleted 		BOOLEAN 		NOT NULL
);