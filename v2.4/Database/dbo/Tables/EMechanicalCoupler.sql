CREATE TABLE [dbo].[EMechanicalCoupler]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EMechanicalCouplerId]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EMechanicalCouplerId] PRIMARY KEY CLUSTERED ([EMechanicalCouplerId] ASC)
);
