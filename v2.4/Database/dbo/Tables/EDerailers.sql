CREATE TABLE [dbo].[EDerailers]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EDerailersId]	BIGINT		NOT NULL,
	[Derailer]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EDerailersId] PRIMARY KEY CLUSTERED ([EDerailersId] ASC),
	CONSTRAINT [FK_EDerailers_TDerailer] FOREIGN KEY ([Derailer]) REFERENCES [dbo].[TDerailer] ([TDerailerId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
