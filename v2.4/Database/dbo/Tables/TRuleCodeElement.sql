CREATE TABLE [dbo].[TRuleCodeElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRuleCodeElementId]	SMALLINT			NOT NULL,
	[RuleCode]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TRuleCodeElementId] PRIMARY KEY CLUSTERED ([TRuleCodeElementId] ASC)
);
