CREATE TABLE [dbo].[ECrossedElements]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ECrossedElementsId]	BIGINT		NOT NULL,
	[CrossedElement]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ECrossedElementsId] PRIMARY KEY CLUSTERED ([ECrossedElementsId] ASC),
	CONSTRAINT [FK_ECrossedElements_TCrossedElement] FOREIGN KEY ([CrossedElement]) REFERENCES [dbo].[TCrossedElement] ([TCrossedElementId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
