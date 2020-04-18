CREATE TABLE [dbo].[TUniqueTrainKey]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TUniqueTrainKeyId]	BIGINT			NOT NULL,
	[TrainNumber]			NVARCHAR(MAX)	NOT NULL,
	[AdditionalTrainNumber]	NVARCHAR(MAX)	NOT NULL,
	[ScopeValue]			TINYINT			NOT NULL,
	[ScopeValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TUniqueTrainKeyId] PRIMARY KEY CLUSTERED ([TUniqueTrainKeyId] ASC),
	CONSTRAINT [FK_TUniqueTrainKey_TTrainScope] FOREIGN KEY ([ScopeValue]) REFERENCES [dbo].[TTrainScope] ([TTrainScopeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
