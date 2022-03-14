--create database Tournaments;

--create table Tournaments();

--DROP SCHEMA public CASCADE;
--CREATE SCHEMA public;

CREATE TABLE IF NOT EXISTS public."dbo.Prizes"
(
    id SERIAL NOT NULL,
    "PlaceNumber" integer NOT NULL,
    "PlaceName" varchar(50) NOT NULL,
    "PrizeAmount" money NOT NULL DEFAULT 0,
    "PrizePercentage" double precision NOT NULL,
    CONSTRAINT "dbo.Prizes_pkey" PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS public."dbo.People"
(
	id SERIAL NOT NULL,
	"FirstName" varchar(12) NOT NULL,
	"LastName" varchar(18) NOT NULL,
	"EmailAddress" varchar(50) NOT NULL,
	"CellphoneNumber" varchar(16) NOT NULL,
	CONSTRAINT "dbo.People_pkey" PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public."dbo.Tournaments"
(
	id SERIAL NOT NULL,
	"TournamentName" varchar(50),
	"EntryFee" money,
	CONSTRAINT "dbo.Tournaments_pkey" PRIMARY KEY (id)
);



CREATE TABLE IF NOT EXISTS public."dbo.TournamentPrizes"
(
    id SERIAL NOT NULL,
    "TournamentId" integer NOT NULL,
    "PrizeId" integer NOT NULL,
    CONSTRAINT "dbo.TournamentPrizes_pkey" PRIMARY KEY (id),
    CONSTRAINT "PrizeId" FOREIGN KEY ("PrizeId")
        REFERENCES public."dbo.Prizes" (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
	CONSTRAINT "TournamentId" FOREIGN KEY("TournamentId")
		REFERENCES public."dbo.Tournaments" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
);


CREATE TABLE IF NOT EXISTS public."dbo.Teams"
(
	id SERIAL NOT NULL,
	"TeamName" varchar(50),
	CONSTRAINT "dbo.Teams_pkey" PRIMARY KEY (id)
);
	
CREATE TABLE IF NOT EXISTS public."dbo.TeamMembers"
(
	id SERIAL NOT NULL,
	"TeamId" integer NOT NULL,
	"PeopleId" integer NOT NULL,
	CONSTRAINT "dbo.TeamMembers_pkey" PRIMARY KEY (id),
	CONSTRAINT "TeamId" FOREIGN KEY("TeamId")
		REFERENCES public."dbo.Teams" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,
	CONSTRAINT "PeopleId" FOREIGN KEY("PeopleId")
		REFERENCES public."dbo.People" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION	
);


CREATE TABLE IF NOT EXISTS public."dbo.TournamentEntries"
(
	id SERIAL NOT NULL,
	"TournamentId" integer NOT NULL,
	"TeamId" integer NOT NULL,
	CONSTRAINT "dbo.TournamentEntries_pkey" PRIMARY KEY(id),
	CONSTRAINT "TournamentId" FOREIGN KEY("TournamentId")
		REFERENCES public."dbo.Tournaments" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,
	CONSTRAINT "TeamId" FOREIGN KEY("TeamId")
		REFERENCES public."dbo.Teams" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
);

CREATE TABLE IF NOT EXISTS public."dbo.Matchups"
(
	id SERIAL NOT NULL,
	"WinnerId" integer NOT NULL,
	"MatchupRound" integer NOT NULL,
	CONSTRAINT "dbo.Matchups_pkey" PRIMARY KEY(id),
	CONSTRAINT "WinnerId" FOREIGN KEY("WinnerId")
		REFERENCES public."dbo.Teams" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
);

/*CREATE TABLE IF NOT EXISTS public."dbo.MatchupEntries"
(
	id SERIAL NOT NULL,
	"MatchupId" integer NOT NULL,
	"ParentMatchupId" integer NOT NULL,
	"TeamCompetingId" integer NOT NULL,
	"Score" integer NOT NULL,
	CONSTRAINT "dbo.MatchupEntries_pkey" PRIMARY KEY(id),
	CONSTRAINT "ParentMatchupId" FOREIGN KEY("ParentMatchupId")
		REFERENCES public."dbo.Matchups" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,
	CONSTRAINT "TeamCompetingId" FOREIGN KEY("TeamCompetingId")
		REFERENCES public."dbo.Teams" (id) MATCH SIMPLE
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,
);
*/
