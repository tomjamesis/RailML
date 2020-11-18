CREATE TABLE [dbo].[TDriversCabType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDriversCabTypeId]	BIGINT			NOT NULL,
	[OrderNumber]		NVARCHAR(MAX)	NOT NULL,
	[Position]			TINYINT			NOT NULL,
	[AcousticSignaller]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TDriversCabTypeId] PRIMARY KEY CLUSTERED ([TDriversCabTypeId] ASC),
	CONSTRAINT [FK_TDriversCabType_TCabPositionType] FOREIGN KEY ([Position]) REFERENCES [dbo].[TCabPositionType] ([TCabPositionTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
