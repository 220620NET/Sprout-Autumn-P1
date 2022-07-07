create schema AutumnERS;

--The constraint is found by running the second command and copy-pasting the specified constraint in the error msg

alter table AutumnERS.users drop constraint PK__users__CBA1B257E40D9164;
-- alter table AutumnERS.users drop constraint UQ__users__CBA1B256FC922998;
alter table AutumnERS.users drop column userid;

alter table AutumnERS.tickets drop column author_fk;
alter table AutumnERS.tickets drop constraint FK__tickets__author___70A8B9AE;

alter table AutumnERS.tickets drop column resolver_fk;
alter table AutumnERS.tickets drop constraint FK__tickets__resolve__719CDDE7;

drop table AutumnERS.users;



create table AutumnERS.users(
	userid int identity (1,1) unique not null,
	username varchar (50) unique not null,
	password varchar (50) not null,
	userrole varchar (50) default 'employee',
	primary key (userid)
);

drop table AutumnERS.tickets;

create table AutumnERS.tickets(
	ticketid int identity (1,1) not null,
	author_fk int foreign key references AutumnERS.users(userid) not null,
	resolver_fk int foreign key references AutumnERS.users(userid),
	description varchar (255) not null,
	status varchar (50) default 'pending',
	amount money not null,
	primary key(ticketid)
);


insert into AutumnERS.users (username, password, userrole) values ('paulstanley', 'kiss', 'manager');
insert into AutumnERS.users (username, password, userrole) values ('genesimmons', 'kiss', 'manager');
insert into AutumnERS.users (username, password) values ('petercriss', 'kiss');
insert into AutumnERS.users (username, password) values ('acefrehley', 'kiss');


insert into AutumnERS.tickets (author_fk, description, amount) values (3, 'kitty litter', 34.99);
insert into AutumnERS.tickets (author_fk, description, amount) values (4, 'cocaine', 678.99);
insert into AutumnERS.tickets (author_fk, description, amount) values (4, 'guitar strings', 22.99);
insert into AutumnERS.tickets (author_fk, description, amount) values (4, 'alcohol', 965.32);
