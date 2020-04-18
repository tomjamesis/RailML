CREATE TABLE [dbo].[TCategory]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCategoryId]				SMALLINT			NOT NULL,
	[TrainUsageValue]			TINYINT			NOT NULL,
	[TrainUsageValueSpecified]	BIT				NOT NULL,
	[DeadrunValue]				BIT				NOT NULL,
	[DeadrunValueSpecified]	BIT				NOT NULL,
	[CategoryPriority]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TCategoryId] PRIMARY KEY CLUSTERED ([TCategoryId] ASC),
	CONSTRAINT [FK_TCategory_TUsageType] FOREIGN KEY ([TrainUsageValue]) REFERENCES [dbo].[TUsageType] ([TUsageTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
