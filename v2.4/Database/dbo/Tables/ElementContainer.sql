CREATE TABLE [dbo].[ElementContainer]
(
	--From MergedXSDs XSD
	--From 'Dc_Elements' Namespace
	[ElementContainerId]	BIGINT		NOT NULL,
	[Any]				BIGINT		NOT NULL,

	CONSTRAINT [PK_ElementContainerId] PRIMARY KEY CLUSTERED ([ElementContainerId] ASC),
	CONSTRAINT [FK_ElementContainer_SimpleLiteral] FOREIGN KEY ([Any]) REFERENCES [dbo].[SimpleLiteral] ([SimpleLiteralId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
