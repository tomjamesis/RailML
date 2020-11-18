CREATE TABLE [dbo].[TElectrificationChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TElectrificationChangeId]	SMALLINT			NOT NULL,
	[MaxTrainCurrent]			BIGINT			NOT NULL,
	[Type]						NVARCHAR(MAX)	NOT NULL,
	[Voltage]					DECIMAL(18, 6)	NOT NULL,
	[Frequency]				DECIMAL(18, 6)	NOT NULL,
	[VMaxValue]				DECIMAL(18, 6)	NOT NULL,
	[VMaxValueSpecified]		BIT				NOT NULL,
	[IsolatedSection]			BIT				NOT NULL,

	CONSTRAINT [PK_TElectrificationChangeId] PRIMARY KEY CLUSTERED ([TElectrificationChangeId] ASC),
	CONSTRAINT [FK_TElectrificationChange_TMaxTrainCurrent] FOREIGN KEY ([MaxTrainCurrent]) REFERENCES [dbo].[TMaxTrainCurrent] ([TMaxTrainCurrentId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
