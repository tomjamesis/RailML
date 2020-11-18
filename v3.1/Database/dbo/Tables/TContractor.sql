CREATE TABLE [dbo].[TContractor]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TContractorId]	SMALLINT			NOT NULL,
	[Role]			NVARCHAR(MAX)	NOT NULL,
	[SubLevel]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TContractorId] PRIMARY KEY CLUSTERED ([TContractorId] ASC)
);
