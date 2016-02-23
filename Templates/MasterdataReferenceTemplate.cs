﻿namespace MWS.Templates
{
    public class MasterdataReferenceTemplate
    {
        public MovilizerMasterdataReference _masterdataReference;

        public MasterdataReferenceTemplate(MovilizerMasterdataReference masterdataReference)
        {
            _masterdataReference = SerializeHelper.CloneObject(masterdataReference);
        }

        public MovilizerMasterdataReference ToMasterdataReference()
        {
            return _masterdataReference;
        }
    }
}
