﻿CREATE TABLE [dbo].[Images] AS FILETABLE FILESTREAM_ON [PastryFiles]
WITH (FILETABLE_COLLATE_FILENAME = Romanian_CI_AS, FILETABLE_DIRECTORY = N'Images');

