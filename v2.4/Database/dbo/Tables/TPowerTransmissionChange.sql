CREATE TABLE [dbo].[TPowerTransmissionChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPowerTransmissionChangeId]	SMALLINT			NOT NULL,
	[Type]						NVARCHAR(MAX)	NOT NULL,
	[Style]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TPowerTransmissionChangeId] PRIMARY KEY CLUSTERED ([TPowerTransmissionChangeId] ASC)
);
