CREATE TABLE [dbo].[TTrain]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainId]					SMALLINT			NOT NULL,
	[Type]						SMALLINT			NOT NULL,
	[TrainNumber]				NVARCHAR(MAX)	NOT NULL,
	[AdditionalTrainNumber]	NVARCHAR(MAX)	NOT NULL,
	[ScopeValue]				TINYINT			NOT NULL,
	[ScopeValueSpecified]		BIT				NOT NULL,
	[ProcessStatus]			NVARCHAR(MAX)	NOT NULL,
	[Remarks]					NVARCHAR(MAX)	NOT NULL,
	[CancellationValue]		BIT				NOT NULL,
	[CancellationValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TTrainId] PRIMARY KEY CLUSTERED ([TTrainId] ASC),
	CONSTRAINT [FK_TTrain_Type] FOREIGN KEY ([Type]) REFERENCES [dbo].[Type] ([TypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TTrain_TTrainScope] FOREIGN KEY ([ScopeValue]) REFERENCES [dbo].[TTrainScope] ([TTrainScopeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
