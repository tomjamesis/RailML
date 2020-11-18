CREATE TABLE [dbo].[ERosterings]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ERosteringsId]	BIGINT		NOT NULL,
	[Rostering]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ERosteringsId] PRIMARY KEY CLUSTERED ([ERosteringsId] ASC),
	CONSTRAINT [FK_ERosterings_ERostering] FOREIGN KEY ([Rostering]) REFERENCES [dbo].[ERostering] ([ERosteringId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
