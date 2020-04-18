CREATE TABLE [dbo].[EBorder]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBorderId]	BIGINT		NOT NULL,
	[Border]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EBorderId] PRIMARY KEY CLUSTERED ([EBorderId] ASC),
	CONSTRAINT [FK_EBorder_TBorder] FOREIGN KEY ([Border]) REFERENCES [dbo].[TBorder] ([TBorderId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
