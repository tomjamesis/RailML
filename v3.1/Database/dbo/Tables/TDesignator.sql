CREATE TABLE [dbo].[TDesignator]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDesignatorId]		BIGINT			NOT NULL,
	[Register]				NVARCHAR(MAX)	NOT NULL,
	[Entry]				NVARCHAR(MAX)	NOT NULL,
	[StartDateValue]		DATETIME			NOT NULL,
	[StartDateValueSpecified]	BIT				NOT NULL,
	[EndDateValue]			DATETIME			NOT NULL,
	[EndDateValueSpecified]BIT				NOT NULL,

	CONSTRAINT [PK_TDesignatorId] PRIMARY KEY CLUSTERED ([TDesignatorId] ASC)
);
