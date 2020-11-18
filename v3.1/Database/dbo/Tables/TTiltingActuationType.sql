CREATE TABLE [dbo].[TTiltingActuationType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTiltingActuationTypeId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(16)	NOT NULL,

	CONSTRAINT [PK_TTiltingActuationTypeId] PRIMARY KEY CLUSTERED ([TTiltingActuationTypeId] ASC)
);
