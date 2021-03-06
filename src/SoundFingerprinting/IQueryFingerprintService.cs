﻿namespace SoundFingerprinting
{
    using System.Collections.Generic;

    using SoundFingerprinting.Query;
    using SoundFingerprinting.Query.Configuration;

    public interface IQueryFingerprintService
    {
        QueryResult Query(IEnumerable<bool[]> fingerprints, IQueryConfiguration queryConfiguration);
    }
}