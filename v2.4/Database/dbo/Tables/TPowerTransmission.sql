CREATE TABLE [dbo].[TPowerTransmission]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPowerTransmissionId]	BIGINT			NOT NULL,
	[Type]					NVARCHAR(MAX)	NOT NULL,
	[Style]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TPowerTransmissionId] PRIMARY KEY CLUSTERED ([TPowerTransmissionId] ASC)
);
