using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oicar.Dal.Entities;

namespace Oicar.Dal.EntityConfigurations
{
    public class NewsPostConfiguration
    {
        public NewsPostConfiguration(EntityTypeBuilder<NewsPost> entity)
        {
            //Password is "admin"
            entity.ToTable("NewsPost");
            entity.HasData(
                new NewsPost() {
                    Id = 1,
                    Title = "Google Cloud teams up with Theta Labs for blockchain-based video delivery",
                    Content = 
                        "Google Cloud has brokered another partnership in its exploration of blockchain technologies, with the company joining the enterprise program of blockchain-based video delivery network Theta Labs. Google has joined the grandly-named Enterprise Validator Program, alongside Binance, Blockchain Ventures, and Gumi, which ‘allows enterprises to validate transactions in accordance with Theta’s underlying consensus protocol’, in its own words. Theta’s business case is to broadly put together a decentralised content delivery network (CDN), which will aim to solve the problems of combining high quality data throughput with no buffering, as well as giving more revenues to content creators rather than arbiters. Blockchain comes in through what the company calls ‘Theta fuel’ – tokens on which a value exchange is based between viewer and video platform. Theta and its partners in the media and entertainment, telecom, technology and gaming industries thus provide a high performance decentralised micropayment network that scales to millions of concurrent video viewers,” Theta wrote in a Medium post.  Google Cloud’s role will be to provide ‘stability, reliability and security’ to the Theta network, in the company’s words. Distributed ledger technology enables new business models that potentially transform the global digital economy, including the media and entertainment industry, said Allen Day, Google Cloud developer advocate. We look forward to participating as an enterprise validator, and to providing Google Cloud infrastructure in support of Theta’s long-term mission and future growth."
                },
                new NewsPost()
                {
                    Id = 2,
                    Title = "Covid-19 has hastened cloud migration – but don’t move without a plan",
                    Content = 
                        "The coronavirus pandemic has magnified the importance of cloud-based technologies in major, life-altering ways and ushered in a new paradigm. Before COVID-19, experts projected the worldwide public cloud services market would jump by 17% this year, reaching $266.4 million. Software as a service is the largest segment within that market, but the second-largest — infrastructure as a service — claims the fastest growth rate.A number of factors are driving businesses to choose the cloud as the standard for applications, data, and storage. They migrate to gain flexible computing power, to lower the cost of backup/recovery, or to turn capital expenses into operational costs. Beyond any single benefit, however, companies migrate to facilitate organisational change in ways that only the cloud can offer.Take artificial intelligence as just one example. Companies that have already implemented AI saw an uptick in revenue, and 44% experienced a reduction in costs. Executives across industries want (and need) to use this technology effectively, and that’s possible from a technical and logistical standpoint only if the technology runs out of the cloud. To put it simply, the cloud is where the future happens, meaning companies either migrate or get left behind."
                    
                },
                new NewsPost()
                {
                    Id = 3,
                    Title = "Gartner: How and why cloud providers need to support their customers through Covid-19",
                    Content = 
                        "Cloud providers need to proactively support their customers through the tail end of the Covid-19 pandemic. They can do this by demonstrating the strength and adaptability of their service offerings. Covid-19 has left many organisations unsure if their business continuity strategy is sufficiently robust, particularly when it comes to cloud services. The reliance on videoconferencing and collaboration tools has stressed the limits of back-end supporting services, while also increasing network traffic volume. However, cloud providers with robust and excess infrastructure, combined with disaster recovery plans to respond to such a crisis, are successfully managing in this new normal. As IT leaders begin to consider longer-term cloud solutions to support the new portion of their workforce remaining remote, they are facing challenging questions about the resiliency and dependability of cloud services. At the same time as Covid-19 has pushed cloud to the spotlight, it has put providers in a unique position to reassure customers of their strength and adaptability.The providers who will fail at this time are the ones still tackling the debate of on-premises data centres vs cloud. Customers are now asking about the adaptability of their current cloud service that they have been forced to adopt if they decided to continue using it post pandemic."
                }
             );
            entity.Property(x => x.Id)
                .HasIdentityOptions(startValue: 4);
        }
    }
}
