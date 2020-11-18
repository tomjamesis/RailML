CREATE TABLE [dbo].[TAirBrakeApplicationPosition]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAirBrakeApplicationPositionId]	TINYINT		NOT NULL,
	[Value]						NVARCHAR(7)	NOT NULL,

	CONSTRAINT [PK_TAirBrakeApplicationPositionId] PRIMARY KEY CLUSTERED ([TAirBrakeApplicationPositionId] ASC)
);
