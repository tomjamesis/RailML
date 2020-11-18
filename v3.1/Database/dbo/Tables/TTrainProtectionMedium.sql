CREATE TABLE [dbo].[TTrainProtectionMedium]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainProtectionMediumId]	TINYINT		NOT NULL,
	[Value]					NVARCHAR(10)	NOT NULL,

	CONSTRAINT [PK_TTrainProtectionMediumId] PRIMARY KEY CLUSTERED ([TTrainProtectionMediumId] ASC)
);
