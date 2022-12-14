create table if not exists public.indextable
(	
	indexId 			INT		NOT NULL	PRIMARY KEY	GENERATED BY DEFAULT AS IDENTITY,
	indexbookcategoryId INT		NULL,
	indexbookId			INT		NULL,
	constraint bookcateogory_fk 
		foreign key (indexbookcategoryId) 
			references public.bookcategories(cateogoryid),
	constraint books_fk 
		foreign key (indexbookId) 
			references public.books(bookid)
);