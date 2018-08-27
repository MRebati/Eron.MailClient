using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eron.mailClient.Application.Core.Enums;
using Eron.MailClient.Business.Core.Infrastructure;
using Eron.MailClient.Business.Core.Services.ImapService.Dto;
using Eron.MailClient.SharedKernel.Modules.ValueObjects;

namespace Eron.MailClient.Business.Core.Services.ImapService
{
    public interface IImapAppService: IApplicationService
    {
        IPagedListResult<EmailSummeryDto> GetEmailsByFolder(EmailDefaultFolderType folderType);
    }

    public class ImapAppService : IImapAppService
    {
        public IPagedListResult<EmailSummeryDto> GetEmailsByFolder(EmailDefaultFolderType folderType)
        {
            throw new NotImplementedException();
        }
    }
}
