CREATE TABLE [dbo].[TElectrification]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TElectrificationId]	BIGINT			NOT NULL,
	[MaxTrainCurrent]	BIGINT			NOT NULL,
	[Type]				NVARCHAR(MAX)	NOT NULL,
	[Voltage]			DECIMAL(18, 6)	NOT NULL,
	[Frequency]		DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TElectrificationId] PRIMARY KEY CLUSTERED ([TElectrificationId] ASC),
	CONSTRAINT [FK_TElectrification_TMaxTrainCurrent] FOREIGN KEY ([MaxTrainCurrent]) REFERENCES [dbo].[TMaxTrainCurrent] ([TMaxTrainCurrentId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
